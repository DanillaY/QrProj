using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace copyqr.Models.Entities;

public partial class QrInfo
{
    public int Id { get; set; }
    public byte[]? Image { get; set; }
    public string? ContentEncode { get; set; }
    public DateTime? DateCreated { get; set; }

    public QrInfo(string content)
    {
        ContentEncode = content;
        QRCodeEncoder qr = new QRCodeEncoder();
        ImageConverter converter = new ImageConverter();
        Image = (byte[])converter.ConvertTo(qr.Encode(ContentEncode), typeof(byte[])); ;
        DateCreated = DateTime.Now;
    }
}
