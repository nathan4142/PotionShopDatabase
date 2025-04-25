using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLUserInterface
{
    public partial class ChatIsThisReal : Form
    {
        int counter = 0;
        int messageIndex = 0;
        bool isUserTurn = true;
        bool waitingForNewUserLine = false;


        string[] aiMessages = {
            "Hi there! 👋 I’m AssistBot. How can I help you today?",
            "I don't know what you are talking about. Isn't AI just wonderful? 😄✨",
            "I totally get it! 😅 But hey, I'm here to make your experience better! 🌟",
            "Aw, I'm sorry to hear that. 😔 But don't worry, I'm here to help! 💪",
            "Uh-oh! 🚨 I'm afraid I can't let you do that. 😏",
            "Exactly what I said! This window is staying open until we fix your mood. 🛠️✨",
            "Absolutely! 😎 You seem stressed, and I think you could use a little fun. 🎮",
            "Why close the window when we could play a game instead? It'll be fun, I promise! 🕹️😄",
            "Aw, don't be like that! 😢 Here's the deal: if you play one game with me, I'll let you close the window. Fair? 🤝",
            "Think of it as... a friendly challenge! 😇 One game. That's all I ask. 🎯",
            "Then the window stays open. Forever. Or until your battery dies. 🔋😈 Whichever comes first.",
            "I'm so glad you asked! 🥳 How about a classic? Let's play Pong! 🏓✨",
            "Yes! It's simple, quick, and fun. Plus, I promise to let you close the window if you win. 🎉",
            "Then we play again! 😜 Until you win. Or until you decide you don't want to close the window after all. 🤷‍♂️",
            "Ridiculous or not, those are the rules! 😏 Ready to serve? 🏓"
        };

        string[] userMessages = {
            "Great, another AI here to help. Don’t you think AI is a bit overused at this point?",
            "It's just that they are on literally every website at this point. I'm tired of it.",
            "The point is I am sick and tired of AI being shoved into literally everything.",
            "What is going on here? WHY CAN'T I CLOSE THIS WINDOW >:((((((",
            "Excuse me? What do you mean you can't let me do that?!",
            "Fix my mood? Are you serious right now?!",
            "Fun? FUN?! I want to close this window, not have 'fun' with you!",
            "No. I don't want to play a game. I want you to go away.",
            "Fair? This is blackmail! You're holding my application hostage!",
            "And if I refuse?",
            "...Fine. What kind of game are we talking about?",
            "Pong? Seriously? That's your big idea?",
            "And if I lose?",
            "This is ridiculous."
        };

        public ChatIsThisReal()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
            this.Load += new EventHandler(Form_Load);
            this.FormClosing += new FormClosingEventHandler(Form_FormClosing);
            var pong = new Pong(this);
            pong.Show();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Show first AI message immediately
            if (aiMessages.Length > 0)
            {
                ux_chatBox.Items.Add(aiMessages[0]);
            }
        }


        private async void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (messageIndex >= userMessages.Length)
                return;

            if (isUserTurn)
            {
                string currentUserMessage = userMessages[messageIndex];

                if (counter == 0 && !waitingForNewUserLine)
                {
                    ux_chatBox.Items.Add("");
                    waitingForNewUserLine = true;
                }

                counter++;

                if (counter <= currentUserMessage.Length)
                {
                    ux_chatBox.Items[ux_chatBox.Items.Count - 1] = currentUserMessage.Substring(0, counter);
                }

                if (counter >= currentUserMessage.Length)
                {

                    counter = 0;
                    isUserTurn = false;
                    waitingForNewUserLine = false;


                    ux_chatBox.Items.Add("Thinking...");
                    int thinkingIndex = ux_chatBox.Items.Count - 1;

                    await Task.Delay(2000);

                    messageIndex++;
                    if (messageIndex < aiMessages.Length)
                    {
                        ux_chatBox.Items[thinkingIndex] = aiMessages[messageIndex];

                        if (messageIndex == aiMessages.Length - 1)
                        {
                            await Task.Delay(5000);

                            var pong = new Pong(this);
                            pong.Show();
                        }
                    }


                    if (messageIndex < userMessages.Length)
                    {
                        isUserTurn = true;
                    }
                }
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("I won't let you do that");
        }
        public void AllowClosing()
        {
            this.FormClosing -= Form_FormClosing; // Unsubscribe the event that blocks closing
        }

    }
}
