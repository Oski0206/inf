def cezar(text, key):
    result = ""
    for c in text:
        if c.islower():
            result += chr((ord(c) - 97 + key) % 26 + 97)
        elif c.isupper():
            result += chr((ord(c) - 65 + key) % 26 + 65)
        else:
            result += c
    return result

if __name__ == "__main__":  # <-- To zapewnia, że kod nie uruchomi się podczas importowania do testów
    tInput = input("Wprowadz text: ")
    kInput = int(input("Wprowadz klucz: "))
    encrypted = cezar(tInput, kInput)
    decrypted = cezar(encrypted, -kInput)
    print("Zaszyfrowany tekst: ", encrypted)
    print("Odszyfrowany tekst: ", decrypted)
