using Obsidian.Entities;
using Obsidian.Packets.Handshaking;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Obsidian.Packets
{
    public class Disconnect
    {
        public Disconnect(Chat reason) => this.Reason = reason;

        Chat Reason;

        public static async Task<Handshake> FromArrayAsync(byte[] data) => throw new NotImplementedException();

        public async Task<byte[]> ToArrayAsync()
        {
            MemoryStream stream = new MemoryStream();
            await stream.WriteChatAsync(this.Reason);
            return stream.ToArray();
        }
    }
}