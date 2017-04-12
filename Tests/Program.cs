using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using net.tipstrade.FCMNet;
using net.tipstrade.FCMNet.Requests;
using net.tipstrade.FCMNet.Responses;
using Newtonsoft.Json;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenResponse re = new TokenResponse();
            try
            {
                string key = "AAAA1wKTmKc:APA91bEXYaRlY5lBXcsImO0OzS1vzjyOyQWcJb7YGLJgnEGAPAZy7Eg5bzvU-78UxwgY21WvxLBpPl9pmBZI9GztMO2a923YA6O9O7C-6OVB5o_evwivCvE3vkbEzGWK0HMWjE7mll1M";
                Message<Notification> m = new Message<Notification>();
                m.To = "APA91bG0GHDuZNVXIM-EuMMo9qBj3qBA4xFVZuuGmwuSJ5B143dVwIVkgoLkN3LbIOaYEoje9ADlqDbmeAYZig5Vt9v9afiWZC6kwUGhk8aeUAPW8jsT4dGZG7jz1FVkB8V1oByaqhsp";
                m.Priority = Priority.High;

                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add("date", DateTime.Now.ToShortDateString());
                data.Add("remarks", "remarks dari .Net Console");
                data.Add("amount", "20");
                data.Add("points", "10");
                m.Data = data;
                //Response r = m.Send(key);
                //Console.WriteLine(r.CanonicalIDs);

                Token t = new Token();
                t.Notification_key = "APA91bFe2BNvjCiOVBBZgRJ60h9-7JzGhqpjErjPB0UF2x_Y1ykRyjj5SKLyIKvASMOcgeEXnwWmdpoG94KlOYuiO7xgSAIr3LNOgpitNzHlbVAxKZzpI94";
                t.Notification_key_name = "andre@gmail.com";
                t.Operation = "add";
                t.Registration_ids = new string[] { "eLlx7ZIWpBo:APA91bGGRKty38D8B8HV7MIWnL-Jwy3xDECRHPQR4n7Fu19k3CikSJOr3jLHZs_Jn5aUqnePI7nJ5BzqXMbe8iJw9xH2cr_L6_iDMagOECgLifhpUe4ALKvmEXEhowaaSNwp4owj6vDV" };
                //re = t.Send(key);

                //Console.WriteLine("send Add : {0}", JsonConvert.SerializeObject(re));

                //t.Operation = "remove";
                //re = t.Send(key);
                //Console.WriteLine("send Remove : {0}", JsonConvert.SerializeObject(re));

                //t.Operation = "create";
                //t.Notification_key_name = "gsedubun@gmail.com";
                //re = t.Send(key);
                //Console.WriteLine("send Create : {0}", JsonConvert.SerializeObject(re));

                //if (re.Error != null)
                //{
                //t.Operation = "remove";
                //t.Notification_key = "APA91bFe2BNvjCiOVBBZgRJ60h9-7JzGhqpjErjPB0UF2x_Y1ykRyjj5SKLyIKvASMOcgeEXnwWmdpoG94KlOYuiO7xgSAIr3LNOgpitNzHlbVAxKZzpI94";
                //t.Notification_key_name = "gsedubun@gmail.com";
                //re = t.Send(key);
                //Console.WriteLine("send Remove : {0}", JsonConvert.SerializeObject(re));
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine("error :"+ex.Message );
            }

        }
    }
}
