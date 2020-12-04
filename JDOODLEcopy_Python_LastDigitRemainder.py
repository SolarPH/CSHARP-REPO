debugMode = True

while (True):
    numericString = ""
    print("Please enter \"END\" or \"0\" to end...")
    print("-"*30)
    numericString = input(str("Enter a 6-digit number: "))
    if (numericString == "END" or numericString == "0"):
        print("Program ended...")
        break
    else:
        allDigit = True
        for i in range(len(numericString)):
            if numericString[i].isdigit() == False:
                allDigit = False
                break
        if allDigit == False:
            print("Not a Number")
        elif (len(numericString)) != 6:
            print ("Not a 6-digit number!")
        else:
            lastNum = (int)(numericString[5])
            value = (int)(numericString[0:5])
            remainder = value%7
            result = remainder==lastNum
            print(result)
        
        print("-"*30)
        if debugMode == True:
            print("DebugMode: ON")
            print("Input:", numericString)
            print("All Digits:", allDigit)
            print("Input Length:", len(numericString))
            if allDigit == True and len(numericString) == 6:
                print("Last Number:", lastNum)
                print("First 5 Digits:", value)
                print("Remainder:", remainder)
            print("-"*30)
