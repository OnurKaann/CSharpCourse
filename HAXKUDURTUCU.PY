import keyboard
import random
import time

# Tuşları liste olarak saklayalım
keys = ["w", "a", "s", "d", "lag", "servetsayar", "nutuk", "sec", "titre"]

while True:
    time.sleep(0.1)
    keyboard.press("enter")
    avatar_key= random.choice(["31","52","69","AM","OC","YE","AH","OH","😊","😀","🤗","😮"])
    keyboard.write(f"/avatar {avatar_key}", delay=0.01)
    keyboard.press("enter")
    time.sleep(0.1)
    # Rastgele bir tuş seçin
    key = random.choice(keys)
    if key == "lag":
        time.sleep(0.1)
        keyboard.press("enter")
        keyboard.write("lagim var arkidislar", delay=0.05)
        keyboard.press("enter")
        time.sleep(0.1)
    elif key == "servetsayar" :
        time.sleep(0.1)
        keyboard.press("enter")
        keyboard.write("SERVET SAYAR KARIMI SEY ETTIN YA SEN!", delay=0.05)
        keyboard.press("enter")
        time.sleep(0.1)
    elif key == "nutuk" :
        time.sleep(0.1)
        keyboard.press("enter")
        keyboard.write("ONLARIN DOLARLARI VARSA BIZIM ALLAHIMIZ VAR!", delay=0.05)
        keyboard.press("enter")
        time.sleep(0.1)
    elif key == "sec" :
        time.sleep(0.2)
        keyboard.press("enter")
        keyboard.write("1", delay=0.1)
        keyboard.press("enter")
        time.sleep(0.2)
    elif key == "titre" :
        time.sleep(0.2)
        keyboard.press("enter")
        keyboard.write("TİTRİYORUM TİTRETME BENİ ALLAHIM!", delay=0.06)
        keyboard.press("enter")
        yon_tuslari = ["w", "a", "s", "d"]
        i = 0
        while i <= 30 :
            for yon in yon_tuslari :
                keyboard.press(yon)
                time.sleep(0.1)
                keyboard.release(yon)
                i = i + 1
        time.sleep(0.1)
    else :
        # Tuşa basılı tutun
        keyboard.press(key)
        time.sleep(1)
        keyboard.release(key)

        # Bekleme zamanı
        time.sleep(0.5)
    
