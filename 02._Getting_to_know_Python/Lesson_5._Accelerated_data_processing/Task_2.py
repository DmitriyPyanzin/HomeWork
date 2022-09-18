# Создайте программу для игры в ""Крестики-нолики""

board = ([1, 2, 3, 4, 5, 6, 7, 8, 9])

# Вывод игрового поля
def draw_board(board):
    counter = 0
    for i in range(len(board)):
        print(board[i], end = '   ')
        counter += 1
        if counter == 3:
            print()
            counter = 0

# Выбор позиции
def take_pos(letter, board):
    flag = True
    while flag:
        draw_board(board)
        pos = input("\nНа какую позицию поставить " + letter + ' \n')
        if not pos in '123456789':
            print('Необходимо ввести число от 1 до 9\n')
            continue
        if board[int(pos) - 1] != int(pos):
            print('Клетка занятата\n')
            continue
        board[int(pos) - 1] = letter
        flag = False
    return board

# Выбор победителя
def win(board, letter):
    if board[0] == letter and board[1] == letter and board[2] == letter: return True
    elif board[3] == letter and board[4] == letter and board[5] == letter: return True
    elif board[6] == letter and board[7] == letter and board[8] == letter: return True
    elif board[0] == letter and board[3] == letter and board[6] == letter: return True
    elif board[1] == letter and board[4] == letter and board[7] == letter: return True
    elif board[2] == letter and board[5] == letter and board[8] == letter: return True
    elif board[0] == letter and board[4] == letter and board[8] == letter: return True
    elif board[2] == letter and board[4] == letter and board[6] == letter: return True
    else: False

# Сие создатели
def Signature():
    print("\n________________________\nthe program was implemented by: \n                     Dmitry Pyanzin\n                     Danila Obgerin\n                     Nikita Muratikov")
    print("                     Valeriya Shevchuk\n                     Aleksey Sidorkin\n                     Konstantin Shestakov\n                     Pavel Ka\n_______________________\n")

# Главный метод
def head():
    print('\nДобро пожаловать в игру "КРЕСТИКИ-НОЛИКИ"\n')
    while True:
        for i in range(9):
            if i > 4:
                if win(board, 'x') == True:
                    print('Победил игрок "x"\n')
                    break
                elif win(board, 'o') == True:
                    print('Победил игрок "o"\n')
                    break
            if i % 2 == 0: take_pos('x', board)
            else: take_pos('o', board)
        if i == 8: print("Ничья\n")
        break
    print("До скорой встречи!")
    Signature()
                
head()