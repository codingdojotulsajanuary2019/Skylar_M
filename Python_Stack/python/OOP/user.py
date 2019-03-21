class user:
    def __init__(self, name, balance):
        self.name = name
        self.balance = balance

    def make_withdrawal(self,amount):
        self.balance -= amount
        return self

    def make_deposit(self,amount):
        self.balance += amount
        return self

    def display_balance(self):
        print(self.name, "=", self.balance)
        return self


Guido = user('Guido',150)
Bob = user('Bob',500)
Betty = user('Betty',1000)


Guido.make_deposit(250).make_deposit(500).make_deposit(50).make_withdrawal(400).display_balance()

Bob.make_deposit(200).make_deposit(200).make_withdrawal(300).make_withdrawal(50).display_balance()

Betty.make_deposit(2000).make_withdrawal(750).make_withdrawal(750).make_withdrawal(250).display_balance()


