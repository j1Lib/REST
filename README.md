# REST

            using (REST xxx = new REST("http://hostname"))
            {
                NameValueCollection QueryString = new NameValueCollection();
                QueryString.Add("id", "xx");
                xxx.GET("url", QueryString, (i) =>
                {
                    Console.Write(i.Content);
                });
                xxx.GET("url?id=xx", null, (i) =>
                {
                    Console.Write(i.Content);
                });
            }
