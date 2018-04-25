using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Discord.Rest;
using System.Diagnostics;

namespace discEmbedTest
{
    public partial class do_the_do : Form
    {
        public string Token;
        public DiscordSocketClient _client = new DiscordSocketClient();
        public do_the_do(string token)
        {
            Token = token;
            InitializeComponent();
            _client.LoginAsync(TokenType.User, Token);
            _client.StartAsync();
        }

        private void do_the_do_Load(object sender, EventArgs e)
        {
            
        }

        private void button_fields_Click(object sender, EventArgs e)
        {

        }

        private void button_send_Click(object sender, EventArgs e)
        {
            SocketGuild guild = _client.GetGuild(Convert.ToUInt64(text_guild_id.Text));
            IMessageChannel channel = guild.GetChannel(Convert.ToUInt64(text_channel_id.Text)) as IMessageChannel;
            EmbedBuilder eb = new EmbedBuilder();
            if (check_title.Checked)
            {
                eb.WithTitle(text_title.Text);
            }
            if (check_img.Checked)
            {
                eb.WithImageUrl(text_img_url.Text);
            }
            if (check_desc.Checked)
            {
                eb.WithDescription(text_desc.Text);
            }
            if (check_footer.Checked)
            {
                eb.WithFooter(text_footer.Text);
            }
            channel.SendMessageAsync("", false, eb);
        }

        private void check_title_CheckedChanged(object sender, EventArgs e)
        {
            text_title.Enabled = check_title.Checked;
        }

        private void check_img_CheckedChanged(object sender, EventArgs e)
        {
            text_img_url.Enabled = check_img.Checked;
        }

        private void check_desc_CheckedChanged(object sender, EventArgs e)
        {
            text_desc.Enabled = check_desc.Checked;
        }

        private void check_footer_CheckedChanged(object sender, EventArgs e)
        {
            text_footer.Enabled = check_footer.Checked;
        }

        private void do_the_do_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.reddit.com/u/ScoobTheBoob");
        }
    }
}
