using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Abstract_Interface.Interfaces
{
    interface IMentalable
    {
        //protected byte _iq; Interface-in icerisinde field qeyd oluna bilmez
        public byte Iq { get; set; }

        //public IMentalable() Interface-in constructoru ola bilmez
        //{

        //}

        //void Test();

    }
}
