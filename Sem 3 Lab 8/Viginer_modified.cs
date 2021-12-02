using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_3_Lab_8
{
    public class Viginer_modified
    {
		private string message;

		private int key;

		private const int pos_x = 10;
		private const int pos_y = 10;

		private List<List<char>> alphabet = new();

		public Viginer_modified()
        {
            message = "";
            key = 0;

			AlphabetGenerate();
		}

        public Viginer_modified(string _message, int _key)
        {
            message = _message;
            key = _key;

			AlphabetGenerate();
		}

		private void AlphabetGenerate()
        {
			for (int i = 0, count = 0; i < pos_x; i++)
			{
				alphabet.Add(new List<char>());
				for (int j = 0; j < pos_y; j++)
				{
					alphabet[i].Add(Convert.ToChar('A' + (count % 26)));

					count++;
				}
			}
		}

        public void SetMessage(string _message)
        {
            message = _message;
        }

        public void SetKey(int _key)
        {
            key = _key;
        }

        public void Key_Encrypt()
		{
			StringBuilder sb = new(message);
			int keyLen = 0;

			for (int temp = key; temp > 0; keyLen++)
			{
				temp /= 10;
			}

			if (key == 0) keyLen++;

			for (int i = 0, t1, t2, count = 0; i < message.Length; i++)
			{
				if (message[i] < '0' || message[i] > '9') continue;
				t2 = keyLen - 1 - count;
				if (t2 < 0)
					t2 = (t2 % keyLen + (keyLen)) % keyLen;

				t1 = Convert.ToInt32(Math.Pow(10, t2));

				int keyPart = ((key / t1) % 10);

				int messagePart = Convert.ToInt32(message[i]- '0');

				sb[i] = alphabet[keyPart][messagePart];

				count++;
			}

			message = sb.ToString();

		}

		public void Key_Decrypt()
		{
			StringBuilder sb = new(message);
			int keyLen = 0;

			for (int temp = key; temp > 0; keyLen++)
			{
				temp /= 10;
			}

			if (key == 0) keyLen++;

			for (int i = 0, t1, t2, count = 0; i < message.Length; i++)
			{
				if (message[i] < 'A' || message[i] > 'Z') continue;
				t2 = keyLen - 1 - count;
				if (t2 < 0)
					t2 = (t2 % keyLen + (keyLen)) % keyLen;

				t1 = Convert.ToInt32(Math.Pow(10, t2));

				int keyPart = ((key / t1) % 10);

				for (int j = 0; j < 10; j++)
				{
					if (message[i] == alphabet[keyPart][j]) sb[i] = Convert.ToChar(Convert.ToInt32(j + '0'));
				}

				count++;

			}

			message = sb.ToString();
		}

        public string GetMessage()
        {
            return message;
        }

    }
}
