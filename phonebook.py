import os.path

def work_with_phonebook():
	
    choice=show_menu()

    phone_book=read_txt('phonebook.txt')

    while (choice!=9):

        if choice==1:
            print_result(phone_book)
        elif choice==2:
            last_name=input('Фамилия: ')
            print(*find_by_lastname(phone_book,last_name))
        elif choice==3:
            corrent_number=input('Номер: ')
            print(*find_by_number(phone_book,corrent_number))
        elif choice==4:
            last_name=input('Фамилия: ')
            new_number=input('Новый номер: ')
            phone_book = change_number(phone_book,last_name,new_number)
            write_txt('phonebook.txt',phone_book)
            print(*find_by_lastname(phone_book,last_name))
        elif choice==5:
            last_name=input('Фамилия: ')
            phone_book = (delete_by_lastname(phone_book,last_name))
            write_txt('phonebook.txt',phone_book)
            print('Контакт удалён.')
        elif choice==6:
            print('Новые данные вписывать через запятую: ')
            user_data=input('Фамилия,Имя,Телефон,Описание: \n')
            phone_book=add_user(phone_book,user_data)
            write_txt('phonebook.txt',phone_book)
        elif choice==7:
            file_name = 'output_file.txt'
            contact_index = input('Номер строки: ')
            if check_index_in (contact_index, phone_book):
                copy_in_new_file(file_name, contact_index, phone_book)
                print(f'Контакт в файле {file_name}')
            else:
                print('Вы пытаетесь вывести несуществующий контакт!')    
        elif choice==8:
            file_name = input('Название файла: ')
            contact_index = input('Номер строки: ')
            if check_index_in (contact_index, phone_book) and os.path.isfile(file_name):
                copy_in_file(file_name, contact_index, phone_book)
                print(f'Контакт в файле {file_name}')
            else:
                print('Вы пытаетесь вывести несуществующий контакт или файла с таким названием не существует!')

        choice=show_menu()

def show_menu():
    print("\nВыберите необходимое действие:\n"
          "1. Отобразить весь справочник\n"
          "2. Найти абонента по фамилии\n"
          "3. Найти абонента по номеру телефона\n"
          "4. Изменить номер абонента по фамилии\n"
          "5. Удалить абонента по фамилии\n"
		  "6. Добавить новый контакт\n"
          "7. Вывести контакт в новый файл\n"
          "8. Добавить контакт в имеющийся файл\n"
          "9. Закончить работу")
    is_int = False
    while is_int==False:
        try:
            choice = int(input("Введите число: "))
            is_int = True
        except ValueError:
            print("Некорректный ввод. Попробуйте снова.")
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

def write_txt(file_name, phone_book):
    with open('phonebook.txt','w',encoding='utf-8') as phout:
        for i in range(len(phone_book)):
            s=''
            for v in phone_book[i].values():
                s = s + v + ','
            if i == len(phone_book)-1:
                phout.write(f'{s[:-1]}\n')
            else:
                phout.write(f'{s[:-1]}')
    
def print_result(phone_book):
    print('\t', end='')
    print(*[head for head in phone_book[0].keys()])
    for contact_index in range(len(phone_book)):
        print(str(contact_index)+'.\t',end='')
        print(*[string for string in phone_book[contact_index].values()], end='')
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

def add_user(phone_book,user_data):
    fields = [head for head in phone_book[0].keys()]
    record = dict(zip(fields, user_data.split(',')))
    phone_book.append(record)
    return phone_book

def change_number(phone_book,last_name,new_number):
    for contact in phone_book:
        if contact['Фамилия']==last_name:
            contact['Телефон'] = new_number
            result = [string for string in contact.values()]
    return phone_book
    
def delete_by_lastname(phone_book,last_name):
    for contact_index in range(len(phone_book)-1):
        if phone_book[contact_index]['Фамилия']==last_name:
            #if contact_index<len(phone_book)-1:
            phone_book = phone_book[:contact_index]+phone_book[contact_index+1:]
            phone_book[-1]['Описание'] = phone_book[-1]['Описание'][:-1]
            # if contact_index>=len(phone_book)-1:
            #     phone_book = phone_book[:contact_index]
            
    return phone_book

def copy_in_new_file(file_name, contact_index, phone_book):
    with open(file_name,'w',encoding='utf-8') as out_file:
        temp_contact=''
        contact_index = int(contact_index)
        for contact_value in phone_book[contact_index].values():
            temp_contact = temp_contact + contact_value + ','
        #print(*temp_contact)
        out_file.write(f'{temp_contact[:-1]}')

def copy_in_file(file_name, contact_index, phone_book):
    with open(file_name,'a',encoding='utf-8') as out_file:
        temp_contact=''
        contact_index = int(contact_index)
        for contact_value in phone_book[contact_index].values():
            temp_contact = temp_contact + contact_value + ','
        #print(*temp_contact)
        out_file.write(f'{temp_contact[:-1]}')
        
def check_index_in (contact_index, phone_book):
    if int(contact_index)<len(phone_book):
        return True
    return False
        
work_with_phonebook()
