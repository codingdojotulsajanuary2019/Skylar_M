class BankAccount:
    def __init__(self, interest_rate, balance = 0):
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


Account1 = BankAccount(.06, 25000)
Account2 = BankAccount(.08, 14000)

Account1.deposit(500).deposit(1000).deposit(200).yield_interest().display_account_info()
Account2.deposit(2000).deposit(500).withdraw(1000).withdraw(1000).withdraw(1000).withdraw(1000).yield_interest().display_account_info()