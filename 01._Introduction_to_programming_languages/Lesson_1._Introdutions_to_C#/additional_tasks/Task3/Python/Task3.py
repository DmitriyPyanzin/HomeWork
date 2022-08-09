print("Введите рост трех спортсменов: ")
growth1, growth2, growth3 = (float(input()) for i in range(3))
print(f"Самый большой рост {max(growth1, growth2, growth3)}, средний рост {growth1 + growth2 + growth3 - max(growth1, growth2, growth3) - min(growth1, growth2, growth3)}, маленький рост {min(growth1, growth2, growth3)}")