static char[] SCombine(string a, string b)
		{

			char[] _return = new char[a.Length + b.Length];
			int pos = 0;

			if (a.Length <= 0 && b.Length <= 0) return _return;
			else if (a.Length <= 0)
			{
				foreach (char c in b)
				{
					_return[pos] = c;
					pos++;
				}
				return _return;
			}
			else if (b.Length <= 0) {
				foreach(char c in a)
				{
					_return[pos] = c;
					pos++;
				}
				return _return;
			}
			else
			{
				if (a.Length >= b.Length)
				{
					for (int i = 0; i < a.Length; i++)
					{
						_return[pos] = a[i];
						pos++;
						if (i < b.Length)
						{
							_return[pos] = b[i];
							pos++;
						}
					}

				}
				else
				{
					for (int i = 0; i < b.Length; i++)
					{
						if (i < a.Length) {
							_return[pos] = a[i];
							pos++;
						}			
						_return[pos] = b[i];
						pos++;
						
					}
				}
				

				return _return;
			}
		}