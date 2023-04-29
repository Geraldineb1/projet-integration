using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Provider
{
    public class CreateProviderDto
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        //public string AccountNb { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        /*public string ApplicationUserId { get; set; }*/

    }
}
