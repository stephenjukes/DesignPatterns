using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class User : IUser
    {
        private Conversation _conversation;
        public string Name { get; set; }

        public User(string name, Conversation conversation)  // changed to IConversation
        {
            Name = name;
            _conversation = conversation;
            _conversation.Register(this);
        }

        public void WriteMessage(string message)
        {
            _conversation.UpdateConversation($"{this.Name}: {message}");
        }

        public void Update()
        {
            foreach (var message in _conversation._messages)
            {
                Console.WriteLine("-- " + message);
            }
        }


    }
}
