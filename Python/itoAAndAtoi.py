def myAtoi(num, base):
    list = []
    while num != 0:
        remainder = num % base;
        num = int(num /10);
        list.append(remainder);
        print(list)
    list1 = list.reverse()
    print(list1)
    return str(list.reverse())


print(myAtoi(253, 10))
