using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCTheme
{
    public partial class Form1 : Form
    {
        delegate bool a();
        a _b;
        a _c;
        a _d;
        a _e;
        a _f;
        a _g;

        Thread Refresher;

        public Form1()
        {
            InitializeComponent();

            Refresher = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        ascTabControl1.Invoke((MethodInvoker)delegate ()
                        {
                            ascTabControl1.Refresh();
                        });
                    }
                    catch
                    {
                        Refresher.Abort();
                    }
                    Thread.Sleep(1);
                }
            });
            Refresher.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_b == null)
                new Thread(() =>
                {
                    for (int i = 0; i < 101; i++)
                    {
                        ascTabControl1.Invoke((MethodInvoker)delegate ()
                        {
                            if (ascTabControl1.Value[0] == 99)
                                i = 0;
                            ascTabControl1.Value[0] = i;

                        });
                        Thread.Sleep(25);
                    }
                }).Start();
            else
                return;
            _b = () => true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_c == null)
                new Thread(() =>
                {
                    for (int i = 0; i < 101; i++)
                    {
                        ascTabControl1.Invoke((MethodInvoker)delegate ()
                        {
                            if (ascTabControl1.Value[1] == 99)
                                i = 0;
                            ascTabControl1.Value[1] = i;
                        });
                        Thread.Sleep(40);
                    }
                }).Start();
            else
                return;
            _c = () => true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_d == null)
                new Thread(() =>
                {
                    for (int i = 0; i < 101; i++)
                    {
                        ascTabControl1.Invoke((MethodInvoker)delegate ()
                    {
                        if (ascTabControl1.Value[2] == 99)
                            i = 0;
                        ascTabControl1.Value[2] = i;
                    });
                        Thread.Sleep(70);
                    }


                }).Start();
            else
                return;
            _d = () => true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_e == null)
                new Thread(() =>
                {
                    for (int i = 0; i < 101; i++)
                    {
                        ascTabControl1.Invoke((MethodInvoker)delegate ()
                        {
                            if (ascTabControl1.Value[3] == 99)
                                i = 0;
                            ascTabControl1.Value[3] = i;
                        });
                        Thread.Sleep(70);
                    }


                }).Start();
            else
                return;
            _e = () => true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_f == null)
                new Thread(() =>
                {
                    for (int i = 0; i < 101; i++)
                    {
                        ascTabControl1.Invoke((MethodInvoker)delegate ()
                        {
                            if (ascTabControl1.Value[4] == 99)
                                i = 0;
                            ascTabControl1.Value[4] = i;
                        });
                        Thread.Sleep(70);
                    }


                }).Start();
            else
                return;
            _f = () => true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_g == null)
                new Thread(() =>
                {
                    for (int i = 0; i < 101; i++)
                    {
                        ascTabControl1.Invoke((MethodInvoker)delegate ()
                        {
                            if (ascTabControl1.Value[5] == 99)
                                i = 0;
                            ascTabControl1.Value[5] = i;
                        });
                        Thread.Sleep(70);
                    }


                }).Start();
            else
                return;
            _g = () => true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ascTabControlSide1.Invoke((MethodInvoker)delegate
            {
                ascTabControlSide1.TabIcon[0] = ASCTheme.Controls.ASCTabControlSide.TabIconEnum.Cancel;
                ascTabControlSide1.Refresh();
            });
            new Thread(() =>
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    for (int i = 0; i < progressBar1.Maximum + 1; i++)
                    {
                        label1.Text = string.Format("Updating Progress: {0}/100%", i);
                        progressBar1.Value = i;
                        Thread.Sleep(35);
                        Refresh();
                    }
                });
                ascTabControlSide1.Invoke((MethodInvoker)delegate
               {
                   ascTabControlSide1.TabIcon[0] = ASCTheme.Controls.ASCTabControlSide.TabIconEnum.OK;
                   ascTabControlSide1.Refresh();
               });
            }).Start();
        }
    }
}
