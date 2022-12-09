using System;
using System.ComponentModel;
using TitaniumAS.Opc.Client.Common;
using TitaniumAS.Opc.Client.Da;


namespace Supervisório___Correia
{
    internal class OPC
    {
        public bool Start;              //0
        public bool Emergency;          //1
        public bool Opaque;             //2
        public bool Transparent;        //3
        public bool Error;              //4
        public bool Reset;              //5
        public bool Busy;               //6
        public int Number_Opaque;       //7
        public int Number_Transparent;  //8

        private string[] items_id = System.IO.File.ReadAllLines(@"ini\OPC.ini");
        private OpcDaGroup group;
        private OpcDaItemDefinition[] opc_da_items;

        public OPC()
        {
            opc_da_items = new OpcDaItemDefinition[items_id.Length];
            Uri url = UrlBuilder.Build("Kepware.KEPServerEX.V6");
            var server = new OpcDaServer(url);

            try
            {
                server.Connect();
                Console.WriteLine("Server connected");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                Console.ReadKey();
            }

            this.group = server.AddGroup("TagsGroup");
            this.group.IsActive = true;

            createItems();
            OpcDaItemResult[] results = this.group.AddItems(this.opc_da_items);
        }

        private void createItems()
        {
            int idx = 0;

            foreach (var item in this.items_id)
            {
                var item_start = new OpcDaItemDefinition
                {
                    ItemId = item,
                    IsActive = true
                };

                this.opc_da_items[idx] = item_start;
                idx++;
            }
        }

        public void ReadBlock()
        {
            OpcDaItemValue[] values = this.group.Read(this.group.Items, OpcDaDataSource.Device);

            this.Start = Convert.ToBoolean(values[0].Value);
            this.Emergency = Convert.ToBoolean(values[1].Value);
            this.Opaque = Convert.ToBoolean(values[2].Value);
            this.Transparent = Convert.ToBoolean(values[3].Value);
            this.Error = Convert.ToBoolean(values[4].Value);
            this.Reset = Convert.ToBoolean(values[5].Value);
            this.Busy = Convert.ToBoolean(values[6].Value);
            this.Number_Opaque = Convert.ToInt32(values[7].Value);
            this.Number_Transparent = Convert.ToInt32(values[8].Value);
        }

        public void WriteBlock()
        {
            object[] values =
            {
                this.Start,
                this.Emergency,
                this.Opaque,
                this.Transparent,
                this.Error,
                this.Reset,
                this.Busy,
                this.Number_Opaque,
                this.Number_Transparent
            };

            HRESULT[] results = this.group.Write(this.group.Items, values);
        }
    }
}
