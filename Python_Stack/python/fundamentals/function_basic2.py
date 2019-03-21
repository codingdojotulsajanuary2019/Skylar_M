
def cntDwn(x):
    nums = []
    i = 0
    for x in range(x, 0, -1):
        nums.append(x)
        i += 1
    return nums
z = cntDwn(5)
print(z)


def pAndR(x):
    print(x[0])
    return x[1]
z = pAndR([1,2])
print(z)


def firstPlusLen(x):
    y = x[0] + len(x)
    return y
print(firstPlusLen([1,2,3,4,5]))


def valGrtThnSec(x):
    nl = []
    for i in range(0, len(x), 1):
        if x[i] > x[1]:
            nl.append(x[i])
    if len(nl) < 2:
        return 'False'
    else:
        return nl
z = valGrtThnSec([5,2,3,2,1,4])
if isinstance(z, list):
    print(len(z))
print(z)


def lenVal(x,y):
    li = []
    for i in range(0, x, 1):
        li.append(y)
    return li
z = lenVal(6,2)
print(z)

