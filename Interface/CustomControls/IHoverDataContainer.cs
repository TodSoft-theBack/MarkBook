using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IHoverDataContainer
    {
        public bool Selected { get; set; }
        public int[] Key { get; set; }
        public bool ContainsDataInfo { get; set; }
        public void Object_Click(object sender, EventArgs e);
    }
}
