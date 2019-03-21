class BankAccount:
    def __init__(self, interest_rate, balance):
        self.interest_rate = interest_rate
        self.balance = balance

    def deposit(self,amount):
        self.balance += amount
        return self

    def withdraw(self,amount):
        self.balance -= amount
        return self

    def display_account_info(self):
        print("Balance:", self.balance, "Interest Rate:", self.interest_rate)
        return self

    def yield_interest(self):
        self.balance = self.balance * (self.interest_rate + 1)
        return self


class user:
    def __init__(self, name):
        self.name = name
        self.account = BankAccount(interest_rate=0.04, balance=0)

    def make_withdrawal(self,amount):
        self.account.balance -= amount
        return self

    def make_deposit(self,amount):
        self.account.balance += amount
        return self

    def display_balance(self):
        print(self.name, "=", self.account.balance)
        return self

an11111 = user("Skylar")
an11111.make_deposit(10000).account.display_account_info()