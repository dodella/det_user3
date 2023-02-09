using AppBeatyShopUser3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBeatyShopUser3.Actions
{
    internal class ConnectDB
    {
        public static det_user3Entities ConnectPoint { get; set; } = new det_user3Entities();
    }
}
