//Перевірка паролю: Напишіть програму, яка перевіряє пароль користувача.
//Пароль вважається прийнятним, якщо він містить принаймні 8 символів, з яких принаймні один символ - це цифра,
//а також принаймні один символ - це спеціальний символ (наприклад, !, @, # тощо).

string userPassword = "";
bool isHasSpecailChars = false;

while (userPassword.Length < 8 || !isHasSpecailChars)
{
	Console.Write("Enter password: ");
	userPassword = Console.ReadLine();

	isHasSpecailChars = false;

	for (int i = 0; i < userPassword.Length; i++)
	{
		if (userPassword[i] == '!' || userPassword[i] == '@')
			isHasSpecailChars = true;
	}
}