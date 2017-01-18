/*
MIT License

Copyright (c) 2016 Ryu-ji

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

*/





using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text;

namespace Encryption
{
    class AES
    {

        Aes aes = new AesCryptoServiceProvider();

        public string Enc(string Origin, string Key, string IV)
        {

            aes.KeySize = 128;
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;


            byte[] byte_KeySize = new byte[16]; //128


            try
            {
                byte[] byte_KeyJustFormatGetBytes = Encoding.UTF8.GetBytes(Key);

                for (int i = 0; i < 16; i++)
                {

                    if (i < Key.Length)
                    {
                        byte_KeyJustFormatGetBytes[i] = byte_KeyJustFormatGetBytes[i];
                    }
                    else
                    {
                        byte_KeySize[i] = 0;
                    }

                }
            }
            catch
            {
                return null;
            }



            byte[] byte_IVSize = new byte[16]; //128


            try
            {
                byte[] byte_IVJustFormatGetBytes = Encoding.UTF8.GetBytes(IV);

                for (int i = 0; i < 16; i++)
                {

                    if (i < IV.Length)
                    {
                        byte_IVJustFormatGetBytes[i] = byte_IVJustFormatGetBytes[i];
                    }
                    else
                    {
                        byte_IVSize[i] = 0;
                    }

                }
            }
            catch
            {
                return null;
            }

            aes.Key = byte_KeySize;
            aes.IV = byte_IVSize;


            ICryptoTransform encryptor = aes.CreateEncryptor();

            byte[] byte_Origin = Encoding.UTF8.GetBytes(Origin);

            byte[] byte_TformFB = encryptor.TransformFinalBlock(byte_Origin, 0, byte_Origin.Length);


            return Convert.ToBase64String(byte_TformFB);



        }


        public string Dec(string Origin, string Key, string IV)
        {


            aes.KeySize = 128;
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;


            byte[] byte_KeySize = new byte[16]; //128

            try
            {
                byte[] byte_KeyJustFormatGetBytes = Encoding.UTF8.GetBytes(Key);

                for (int i = 0; i < 16; i++)
                {

                    if (i < Key.Length)
                    {
                        byte_KeyJustFormatGetBytes[i] = byte_KeyJustFormatGetBytes[i];
                    }
                    else
                    {
                        byte_KeySize[i] = 0;
                    }

                }
            }
            catch
            {
                return null;
            }



            byte[] byte_IVSize = new byte[16]; //128


            try
            {
                byte[] byte_IVJustFormatGetBytes = Encoding.UTF8.GetBytes(IV);

                for (int i = 0; i < 16; i++)
                {

                    if (i < IV.Length)
                    {
                        byte_IVJustFormatGetBytes[i] = byte_IVJustFormatGetBytes[i];
                    }
                    else
                    {
                        byte_IVSize[i] = 0;
                    }

                }
            }
            catch
            {
                return null;
            }

            aes.Key = byte_KeySize;
            aes.IV = byte_IVSize;

            ICryptoTransform decryptor = aes.CreateDecryptor();

            byte[] byte_Origin = Convert.FromBase64String(Origin);

            byte[] byte_TformFB = decryptor.TransformFinalBlock(byte_Origin, 0, byte_Origin.Length);



            return Encoding.UTF8.GetString(byte_TformFB);
        }

    }

    class RSA
    {

        public string public_key = String.Empty, private_key = String.Empty;


        private static string str_ContainerName = String.Empty;



        public string Enc(string origin, string publickey)
        {

            StringBuilder sb = new StringBuilder();

            string str_ans = EncryptFunction(origin, public_key);

            sb.AppendFormat("{0:x2}", str_ans.ToString());


            return sb.ToString();

        }

        public string Dec(string EncCode, string privatekey)
        {
            StringBuilder sb_Origin = new StringBuilder();

            string str_ans = DecuryptionFunction(EncCode, private_key);

            sb_Origin.AppendFormat("{0:x2}", str_ans.ToString());

            return sb_Origin.ToString();
        }

        public void DeleteKeyContainer()
        {
            CspParameters pp = new CspParameters();

            pp.KeyContainerName = str_ContainerName;

            using (RSACryptoServiceProvider RsaCryptoProvider = new RSACryptoServiceProvider(pp))
            {
                RsaCryptoProvider.PersistKeyInCsp = false;

                RsaCryptoProvider.Dispose();
            }

            public_key = String.Empty;
            private_key = String.Empty;

        }

        public void CreateKeys()
        {
            str_ContainerName = Guid.NewGuid().ToString("N").Substring(0, 10);

            var var_key = KeyProcessing(str_ContainerName);

            public_key += var_key.Key;
            private_key += var_key.Value;

        }

        /*Private*/
        private KeyValuePair<String, String> KeyProcessing(string KCN/*Container name*/)
        {
            CspParameters var_pp = new CspParameters();

            var_pp.KeyContainerName = KCN;

            RSACryptoServiceProvider RsaCryptoProvider = new RSACryptoServiceProvider(var_pp);

            return new KeyValuePair<string, string>(RsaCryptoProvider.ToXmlString(false), RsaCryptoProvider.ToXmlString(true));

        }

        private string EncryptFunction(string origin, string publickey)
        {


            using (RSACryptoServiceProvider RsaCryptoProvider = new RSACryptoServiceProvider())
            {
                RsaCryptoProvider.FromXmlString(publickey);

                byte[] byte_Data = Encoding.UTF8.GetBytes(origin);

                byte[] byte_EncData = RsaCryptoProvider.Encrypt(byte_Data, false);

                return Convert.ToBase64String(byte_EncData);
            }
        }

        private string DecuryptionFunction(string EncCode, string privatekey)
        {
            using (RSACryptoServiceProvider RsaCryptoProvider = new RSACryptoServiceProvider())
            {

                RsaCryptoProvider.FromXmlString(privatekey);

                byte[] byte_Data = Convert.FromBase64String(EncCode);

                byte[] byte_dec = RsaCryptoProvider.Decrypt(byte_Data, false);


                return Encoding.UTF8.GetString(byte_dec);
            }
        }


    }


    class Sha256
    {
        public string Enc(string origin)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();

            StringBuilder sb = new StringBuilder();

            byte[] byte_GetBytes = Encoding.UTF8.GetBytes(origin);

            byte[] byte_compute = sha256.ComputeHash(byte_GetBytes);

            for (int i = 0; i < byte_compute.Length; i++)
            {
                sb.AppendFormat("{0:x2}", byte_compute[i]);

            }

            return sb.ToString();
        }


    }



    namespace Key
    {
        class KeyProvider
        {
            public string CreateKey(string password)
            {

                //create key
                SHA256 sha256 = new SHA256CryptoServiceProvider();

                StringBuilder sb_origin = new StringBuilder();
                StringBuilder sb_Seed = new StringBuilder();


                for (int i = 0; i < 2; i++)
                {

                    if (i == 1)
                    {

                        byte[] byte_GetBytes = Encoding.UTF8.GetBytes(password);

                        byte[] byte_compute = sha256.ComputeHash(byte_GetBytes);

                        for (int j = 0; j < byte_compute.Length; j++)
                        {
                            sb_origin.AppendFormat("{0:x2}", byte_compute[j]);
                        }

                    }
                    else
                    {
                        byte[] byte_GetSeedBytes = Encoding.UTF8.GetBytes(CreateSeed());

                        byte[] byte_SeedHashCompute = sha256.ComputeHash(byte_GetSeedBytes);

                        for (int k = 0; k < byte_SeedHashCompute.Length; k++)
                        {
                            sb_Seed.AppendFormat("{0:x2}", byte_SeedHashCompute[k]);
                        }
                    }


                }


                string str_Sum = sb_origin.ToString() + sb_Seed.ToString();

                return "";
            }


            public string KeyJustSize(string key)
            {

                byte[] byte_basesize = new byte[16];


                byte[] byte_InputKeyBytes = Encoding.UTF7.GetBytes(key);


                for (int i = 0; i < 16; i++)
                {
                    if (i < key.Length)
                    {
                        byte_InputKeyBytes[i] = byte_InputKeyBytes[i];
                    }
                    else
                    {
                        byte_basesize[i] = 0;
                    }
                }


                return key;
            }



            public string CreateSeed()
            {
                return Guid.NewGuid().ToString("N").Substring(0, 20);

            }



        }




    }

}


