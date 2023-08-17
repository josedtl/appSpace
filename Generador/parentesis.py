import re

texto = "decimal"

resultado = re.sub(r'\([^)]*\)', '', texto)

print(resultado)