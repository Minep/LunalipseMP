﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEaseHijacker.Types
{
    public class SDetail
    {
        public string id, name, ar_name, al_pic,al_name;
        //Store as <bitRate>|<size>
        public long[] sizes = new long[3];
        public int[] bitrate = new int[3];
    }
}
