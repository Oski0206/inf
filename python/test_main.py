from main import cezar 

def test_CezarBasic():
    assert cezar("abc", 1) == "bcd"
    assert cezar("xyz", 3) == "abc"
    assert cezar("ABC", 1) == "BCD"
    assert cezar("XYZ", 3) == "ABC"

def test_CezarWithSymbols():
    assert cezar("Hello World! 123", 5) == "Mjqqt Btwqi! 123"
    assert cezar("Mjqqt Btwqi! 123", -5) == "Hello World! 123"

if __name__ == "__main__":
    test_CezarBasic()
    test_CezarWithSymbols() 
    print("Wszystkie testy przeszły pomyślnie!")
