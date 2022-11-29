using System;
using System.ComponentModel;
using TitaniumAS.Opc.Client.Common;
using TitaniumAS.Opc.Client.Da;


namespace Supervisório___Correia
{
    internal class OPC
    {
        public Boolean Start;
        public Boolean Emergency;
        public Boolean Opaque;
        public Boolean Transparent;
        public Boolean Error;
        public Boolean Reset;
        public Boolean Busy;
        public int Number_Opaque;
        public int Number_Transparent;

        private string[] items_id = { "Channel1.Device1.Start",
                                    "Channel1.Device1.Emergency",
                                    "Channel1.Device1.Opaque",
                                    "Channel1.Device1.Transparent",
                                    "Channel1.Device1.Error",
                                    "Channel1.Device1.Reset",
                                    "Channel1.Device1.Busy",
                                    "Channel1.Device1.NumOpcOpaque",
                                    "Channel1.Device1.NumTransp"};

        private OpcDaGroup group;
        private OpcDaItemDefinition[] opc_da_items = new OpcDaItemDefinition[9];

        public OPC()
        {
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
