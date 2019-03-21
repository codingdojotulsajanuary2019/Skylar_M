if player_choice == cpu_choice:
    outcome = 'Draw'
if player_choice == 'rock' and cpu_choice == 'scissors':
    outcome = 'Win'
if player_choice == 'paper' and cpu_choice == 'rock':
    outcome = 'Win'
if player_choice == 'scissors' and cpu_choice == 'paper':
    outcome = 'Win'
elif:
    outcome = 'Lose'