# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.



if __name__ == '__main__':
    input = ["Hello", "2", "World", ":-)"]
    count = 0
    resultcount = 0
    result = []
    for item in input:
        if len(item)<=3:
            result.append(item)

    print(result)

# See PyCharm help at https://www.jetbrains.com/help/pycharm/
