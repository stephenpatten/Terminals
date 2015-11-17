﻿using System;
using System.Windows.Forms;
using Terminals.Data;
using Terminals.Forms.EditFavorite;

namespace Terminals.Connections.VNC
{
    internal class VncConnectionPlugin : IConnectionPlugin
    {
        internal const string VNC = "VNC";

        public int Port { get { return KnownConnectionConstants.VNCVMRCPort; } }

        public string PortName { get { return VNC; } }

        public Connection CreateConnection()
        {
            //return new FakeVNCConnection();
            return new VNCConnection();
        }

        public Control[] CreateOptionsControls()
        {
            return new Control[] { new VncControl() { Name = "VNC" } };
        }

        public Type GetOptionsType()
        {
            return typeof (VncOptions);
        }

        public ProtocolOptions CreateOptions()
        {
            return new VncOptions();
        }
    }
}
