using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class User
    {
        private String name;
        public User(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void sendMessage(String message)
        {
            InterCom.SendMessage(this, message);
        }
    }
}
