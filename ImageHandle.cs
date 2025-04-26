using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MobileStoreManagement
{
    internal static class  ImageHandle
    {

        public static byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        public static Image GetImage(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Tệp không tồn tại: " + filePath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                // Dùng Image.FromStream để tránh lỗi file bị khóa
                using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var imgTemp = Image.FromStream(fs))
                    {
                        return new Bitmap(imgTemp); // clone ảnh
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
