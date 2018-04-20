#!/usr/bin/env bash

toilet -f mono12 PhoneBook Tester -t
echo -e "\033[32[+]Testing The Address Book"
 for user in $( cat /etc/passwd | cut -d : -f 1); do
  curl --silent -d "name=$user&Phone=425390231&Address=503 215353f&button" --user-agent "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36" http://localhost:5000/create;
done
