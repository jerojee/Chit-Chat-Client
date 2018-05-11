using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChitChatClient
{
    public class Chatroom
    {
        public RichTextBox chatBox;
        public string chatRoomName;
        public List<string> chatBoxTextLines = new List<string>();
    }
}
