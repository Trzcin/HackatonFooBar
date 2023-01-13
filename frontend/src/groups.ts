export interface Group {
  name: string;
  primary: boolean;
  icon?: string;
  categories: string[];
}

export const groups: Group[] = [
  {
    name: "Zdrowie i Usługi",
    primary: true,
    icon: "health_and_services.svg",
    categories: [
      "apteka",
      "dentysta",
      "lekarz",
      "opieka zdrowotna",
      "ortodonta",
      "przychodnia",
      "bank",
      "biuro",
      "drukarnia",
      "dzieci",
      "fotograf",
      "sklep spożywczy",
      "mechanik",
      "monopolowy",
      "urzędy",
      "pralnia",
      "prawnik",
      "przedszkole",
      "transport autokary",
      "remonty",
      "serwis rowerowy",
      "sklepy ogólne",
      "galeria handlowa",
      "sklep AGD",
      "sprzątanie",
      "stacja paliw",
      "stacje transportu publicznego - bilety",
      "stolarz",
      "transport - tiry",
      "basen",
      "fitness",
      "siłownia",
      "sport ogólnie",
      "catering",
    ],
  },
  {
    name: "Miejsce do Pójścia",
    primary: true,
    icon: "places.svg",
    categories: [
      "atrakcje",
      "kultura",
      "entertainment",
      "hotel",
      "impreza",
      "muzeum",
      "plac",
      "kawiarnia",
      "fastfood",
      "pub",
      "restauracje",
      "cukiernia",
      "kościół",
      "cmentarz",
    ],
  },
  {
    name: "Komunikacja",
    primary: true,
    icon: "transport.svg",
    categories: ["przystanek autobusowy", "stacja SKM", "przystanek tramwaju"],
  },
  {
    name: "Przyroda",
    primary: true,
    icon: "nature.svg",
    categories: ["plaża", "zbiornik wodny", "las", "park"],
  },
  {
    name: "Sport",
    primary: false,
    categories: [
      "basen",
      "fitness",
      "siłownia",
      "sport ogólnie",
      "serwis rowerowy",
    ],
  },
  {
    name: "Atrakcje",
    primary: false,
    categories: ["atrakcje", "impreza"],
  },
  {
    name: "Kultura",
    primary: false,
    categories: ["kultura", "muzeum", "plac"],
  },
  {
    name: "Restauracje",
    primary: false,
    categories: ["restauracje", "cukiernia", "pub", "fastfood", "kawiarnia"],
  },
  {
    name: "Dzieci",
    primary: false,
    categories: ["dzieci", "przedszkole", "szkoła"],
  },
  {
    name: "Student",
    primary: false,
    categories: ["uniwersytet", "impreza"],
  },
  {
    name: "Senior",
    primary: false,
    categories: [
      "przychodnia",
      "apteka",
      "sklep spożywczy",
      "piekarnia",
      "lekarz",
      "opieka zdrowotna",
    ],
  },
];
