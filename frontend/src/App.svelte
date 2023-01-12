<script lang="ts">
  import Navbar from "./components/Navbar.svelte";
  import Map from "./components/Map.svelte";
  import CategoryGrid from "./components/CategoryGrid.svelte";
  import type Category from "./types/category";
  import CategoryFilterInput from "./components/CategoryFilterInput.svelte";

  const data: Category[] = [
    {
      name: "Apteka",
      nearest: {lon: 50, lat: 50},
      time: "7 minut"
    },
    {
      name: "Sklep Spożywczy",
      nearest: {lon: 50, lat: 50},
      time: "7 minut"
    },
    {
      name: "Przedszkole",
      nearest: {lon: 50, lat: 50},
      time: "7 minut"
    },
    {
      name: "Szkoła Podstawowa",
      nearest: {lon: 50, lat: 50},
      time: "7 minut"
    },
    {
      name: "Przychodnia",
      nearest: {lon: 50, lat: 50},
      time: "7 minut"
    },
    {
      name: "Restauracja",
      nearest: {lon: 50, lat: 50},
      time: "7 minut"
    },
  ];
  let displayData: Category[] = [...data];
</script>

<Navbar />
<Map />
<CategoryFilterInput {data} bind:displayData={displayData} />
<CategoryGrid data={displayData} />

