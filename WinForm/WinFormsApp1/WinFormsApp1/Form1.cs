using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNano;
using DotNano.CodeGeneration;
using DotNano.RpcApi;
using DotNano.RpcApi.Responses;
using DotNano.RpcDocParser;
using DotNano.Shared;
using DotNano.Shared.DataTypes;


/// <summary>
/// Rowjelio, 6/20/2021
/// most of this code is from Jerzy Stanislawski's DOT NANO project. He is an awesome guy and deserves 80% of the credit!
/// I didnt even change the references of the namespace to make sure he gets most of the kudos here! He's a freakin genius!
/// I did re compile them as .net framework 4.8 and added a windows form project
/// the github for that is https://github.com/JerzyStanislawski/DotNano
/// I also changed certain parts so that it works with BANANO addresses and not NANO addresses.
/// Dont forget to check out the NANO RPC calls to see how you need to do things here
/// https://docs.nano.org/commands/rpc-protocol/
/// </summary>


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Note the ASYNC in the button click event!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnGetBal_Click(object sender, EventArgs e)
        {
            try
            {
                //set up the client object using the address and port of the node you wish to use
                var client = new DotNano.RpcApi.NanoRpcClient(txtNode.Text, int.Parse(txtPort.Text));

                //get the account balance
                var ressy = await client.AccountBalance(txtBananoAddress.Text);

                //show it on the label!
                lblBal.Text = DotNano.Shared.Tools.ToNano(ressy.Balance).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //set up the client object using the address and port of the node you wish to use
                var client = new DotNano.RpcApi.NanoRpcClient(txtNode.Text, int.Parse(txtPort.Text));

                //get the account balance
                var ressy = await client.AccountHistory(txtBananoAddress.Text, 10, false);


                if (ressy.History != null)

                {

                    int i = 0;
                    foreach (var cust in ressy.History)
                    {
                        txtHistoryStuff.Text = txtHistoryStuff.Text + cust.Type.ToString() + Environment.NewLine +
                            "From: " + cust.Account.ToString() + Environment.NewLine +
                            "Amount: " + DotNano.Shared.Tools.ToNano(cust.Amount).ToString().TrimEnd('0') + Environment.NewLine +
                           "Time Stamp: " + DateTimeOffset.FromUnixTimeSeconds(cust.LocalTimestamp).UtcDateTime + Environment.NewLine +
                           "Hash: " + cust.Hash.ToString() + Environment.NewLine + "-----------------" + Environment.NewLine;

                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new DotNano.RpcApi.NanoRpcClient(txtNode.Text, int.Parse(txtPort.Text));

                //Sending is tricky. far as I know, you can only send from the Wallet of the NODE ? I could be wrong.
                //I couldnt get it to work with a different seed other than the seed for the wallet that is built into the NODE
                //this of course can only be obtained by running your own node. That's a whol different set of work that
                //I can't get into here!
                var sendyBlock = await client.Send("THE SEED", "BAN_xx(FROM ADDRESS)", "ban___(TO ADDRESS)", 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
