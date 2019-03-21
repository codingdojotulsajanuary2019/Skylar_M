
def bigSize(x):
    for i in range(0, len(x)-1, 1):
        if x[i] > 0:
            x[i] = 'big'
    return x
print(bigSize([-1,-1,2,2,-1]))


def countPosi(x):
    count = 0
    for i in range(0, len(x), 1):
        if x[i] > 0:
            count += 1
    x[len(x)-1] = count
    return x
print(countPosi([-1,1,1,1]))


def sumTot(x):
    sum = 0
    for i in range(0, len(x), 1):
        sum += x[i]
    return sum
print(sumTot([1,2,3,4]))


def avg(x):
    sum = 0
    for i in range(0, len(x), 1):
        sum += x[i]
    return sum / len(x)
print(avg([1,2,3,4]))


def length(x):
    val = len(x)
    return val
print(length([1,2,3,4,5]))


def minimum(x):
    if not x:
        return 'False'
    small = x[0]
    for i in range(0, len(x), 1):
        if x[i] < small:
            small = x[i]
    return small
print(minimum([37,2,1,-9]))


def maximum(x):
    if not x: return 'False'
    big = x[0]
    for i in range(0, len(x), 1):
        if x[i] > big:
            big = x[i]
    return big
print(maximum([37,2,1,-9]))


def ultimate(x):
    total = sumTot(x)
    average = avg(x)
    mini = minimum(x)
    maxi = maximum(x)
    length = len(x)
    dictionary = {
        "sumTotal": total,
        "average": average,
        "minimum": mini,
        "maximum": maxi,
        "length": length
    }
    return dictionary
print(ultimate([37,2,1,-9]))


def rev(x):
    x.reverse()
    return x
print(rev([1,2,3,4,5]))