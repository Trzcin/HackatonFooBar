# 15 Minute City

Aplikacja internetowa pomagającą określenie atrakcyjności miejsca zamieszkania pod względem założeń miasta 15 minutowego.

![image1](https://github.com/Trzcin/HackatonFooBar/blob/main/docs/image1.png?raw=true)
![image2](https://github.com/Trzcin/HackatonFooBar/blob/main/docs/image2.png?raw=true)
![image3](https://github.com/Trzcin/HackatonFooBar/blob/main/docs/image3.png?raw=true)

## Instrukcja uruchomienia

### Frontend

Do uruchomienia wymagany jest token Mapbox. Należy go przypisać do zmiennej środowiskowej `VITE_MAPBOX`.
W tym celu można utworzyć plik `frontend/.env` z zawartością:
```
VITE_MAPBOX=<token>
```

```bash
cd frontend
npm i
npm run dev
```

### Backend

```bash
cd backend
docker-compose up
```
