using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using PGENL0006;
using System.Diagnostics;
using System.Security.Permissions;

namespace PVHLF0001
{
    public partial class frm_EnvioMensaje : Form
    {
        //TcpListener servidor = new TcpListener(IPAddress.Any, 8888);
        //TcpClient cliente_aceptado = null;        
        //CDI_L_MensajeSocket ER = new CDI_L_MensajeSocket();
        TcpListener serverSocket = new TcpListener(IPAddress.Any,8888);
        TcpClient clientSocket = default(TcpClient);        
        Thread tIniciar;
        

        public frm_EnvioMensaje()
        {
            InitializeComponent();                       
            tIniciar = new Thread(new ThreadStart(mIniciar));
        }
        private void tmrEscuchar_Tick(object sender, EventArgs e)
        {
            //if (servidor.Pending()) // Determina si hay conexiones pendientes
            //{
            //    cliente_aceptado = servidor.AcceptTcpClient();
            //}
        }
        private void tmrRecibir_Tick(object sender, EventArgs e)
        {
            //try
            //{
            //    if (cliente_aceptado.Available > 0)//Si hay informacion disponible que leer
            //    {
            //        rtbMensajeEnviado.Text += "Pantalla: " + ER.CDI_F_Recibir(cliente_aceptado) + "\n";
            //    }
            //}
            //catch (Exception)
            { }
        }

        private void frm_EnvioMensaje_Load(object sender, EventArgs e)
        {
            //tmrIniciar.Start();
            tIniciar.IsBackground = true;
            tIniciar.Start();
            //servidor.Start();
            //tmrEscuchar.Start();
        }

        private void btnMostrarMensaje_Click(object sender, EventArgs e)
        {
            mEscribir();
            txtMensaje.Text = "";
            //if (txtMensaje.Text != "")
            //{
            //    ER.CDI_P_Enviar(cliente_aceptado, txtMensaje.Text);//Enviar mensaje
            //    rtbMensajeEnviado.Text += "Yo: " + txtMensaje.Text + "\n"; //Efecto de conversación
            //    txtMensaje.Text = "";
            //}

        }

        private void frm_EnvioMensaje_FormClosing(object sender, FormClosingEventArgs e)
        {            
                //ER.CDI_P_Enviar(cliente_aceptado, "CDI-0");               
            try
            {
                mKillThread();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }
        private void mIniciar()
        {
            
            serverSocket.Start();            
            clientSocket = serverSocket.AcceptTcpClient();
            //tIniciar.Abort();
            //tIniciar.Join();            
            
        }
        private void mEscribir()
        {   
            //while ((true))
            //{
                try
                {                    
                    NetworkStream networkStream = clientSocket.GetStream();
                    string serverResponse = txtMensaje.Text ;
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                    rtbMensajeEnviado.AppendText(serverResponse+Environment.NewLine);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    //if (!(clientSocket == null))
                    {
                        clientSocket.Close();
                        serverSocket.Stop();
                    }
                    serverSocket.Start();
                    clientSocket = serverSocket.AcceptTcpClient();
                }
           // }

            //clientSocket.Close();
            //serverSocket.Stop();
            //Console.WriteLine(" >> Salir");
            //Console.ReadLine();
        }
        private void mCerrarConexion()
        {
            tIniciar.Suspend();
            try
            {
                clientSocket.Close();
                serverSocket.Stop();
                Console.WriteLine(" >> Salir");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
            }
        }
        //[SecurityPermissionAttribute(SecurityAction.Demand, ControlThread = true)]
        private void mKillThread()
        {           
            tIniciar.Abort (tIniciar);            
        }

        private void tmrIniciar_Tick(object sender, EventArgs e)
        {
            mIniciar();
        }
    }
}
