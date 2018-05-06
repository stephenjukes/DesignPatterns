using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Conversation : IConversation
    {
        List<IUser> _users = new List<IUser>();
        public List<string> _messages = new List<string>();
        private int messageId = 0;

        public void Register(IUser user)
        {
            _users.Add(user);
        }

        public void Unregister(IUser user)
        {
            _users.Remove(user);
        }

        public void UpdateConversation(string message)
        {
            _messages.Add(message);
            Notify();
        }

        public void Notify()
        {
            Console.WriteLine($"MESSAGE: {++messageId} \n");

            foreach(var user in _users)
            {
                Console.WriteLine("* " + user.Name);
                user.Update();
            }

            Console.WriteLine(Environment.NewLine);
        }
    }
}
