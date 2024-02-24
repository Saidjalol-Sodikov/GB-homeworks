def work_with_phonebook():
	
    choice=show_menu()

    phone_book=read_txt('phonebook.txt')

    while (choice!=10):

        if choice==1:
            print_result(phone_book)
        elif choice==2:
            last_name=input('Фамилия: ')
            print(*find_by_lastname(phone_book,last_name))
        elif choice==3:
            corrent_number=input('Номер: ')
            print(*find_by_number(phone_book,corrent_number))
        elif choice==4:
            last_name=input('lastname ')
            new_number=input('new  number ')
            print(change_number(phone_book,last_name,new_number))
        elif choice==5:
            lastname=input('lastname ')
            print(delete_by_lastname(phone_book,lastname))
        elif choice==6:
            number=input('number ')
            print(find_by_number(phone_book,number))
        elif choice==7:
            user_data=input('new data ')
            add_user(phone_book,user_data)
            write_txt('phonebook.txt',phone_book)


        choice=show_menu()

def show_menu():
    print("\nВыберите необходимое действие:\n"
          "1. Отобразить весь справочник\n"
          "2. Найти абонента по фамилии\n"
          "3. Найти абонента по номеру телефона\n"
          "4. Добавить абонента в справочник\n"
		  "5. Сохранить справочник в текстовом формате\n"
          "6. Закончить работу")
    choice = int(input())
    return choice

def read_txt(filename): 
    phone_book=[]
    fields=['Фамилия', 'Имя', 'Телефон', 'Описание']
    with open(filename,'r',encoding='utf-8') as phb:
        for line in phb:
            record = dict(zip(fields, line.split(',')))
		    #dict(( (фамилия,Иванов),(имя, Точка),(номер,8928) ))     
            phone_book.append(record)	
    return phone_book

def write_txt(filename, phone_book):

    with open('phonebook.txt','w',encoding='utf-8') as phout:

        for i in range(len(phone_book)):

            s=''
            for v in phone_book[i].values():

                s = s + v + ','

            phout.write(f'{s[:-1]}\n')

def print_result(phone_book):
    print(*[head for head in phone_book[0].keys()])
    for contact in phone_book:
        print(*[string for string in contact.values()], end='')
    print()

def find_by_lastname(phone_book,last_name):
    result = list()
    for contact in phone_book:
        if contact['Фамилия']==last_name:
            result = [string for string in contact.values()]
    return result

def find_by_number(phone_book,number):
    result = list()
    for contact in phone_book:
        if contact['Телефон']==number:
            result = [string for string in contact.values()]
    return result

work_with_phonebook()
