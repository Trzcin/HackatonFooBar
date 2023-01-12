<script lang="ts">
  import Navbar from "./components/Navbar.svelte";
  import Map from "./components/Map.svelte";
  import CategoryGrid from "./components/CategoryGrid.svelte";
  import type Category from "./types/category";
  import CategoryFilterInput from "./components/CategoryFilterInput.svelte";
  import GroupPicker from "./components/GroupPicker.svelte";
  import Rating from "./components/Rating.svelte";
  import GroupRating from "./components/GroupRating.svelte";
  import { groups } from "./groups";
  import type { Group } from "./groups";
  import {onMount} from "svelte";

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
  let groupData: Category[] = [...data];
  let displayData: Category[] = [...groupData];

  let displayGroups: Group[] = [...groups];

  $: {
    groupData = data.filter(c => {
      let found = false;
      for (const group of displayGroups) {
        found = group.categories.includes(c.name);
        if (found) break;
      }
      return found;
    });
  }

  let mapExpanded = true;

  onMount(() => {
    window.scrollTo(0, 0);
  });
</script>

<Navbar />
<Map bind:mapExpanded={mapExpanded}/>
{#if !mapExpanded}
  <Rating />
  <GroupPicker groups={groups.filter(g => !g.primary)} bind:displayGroups={displayGroups}/>
  <GroupRating groups={displayGroups}/>
  <CategoryFilterInput {data} bind:displayData={displayData} {groupData}/>
  <CategoryGrid data={displayData} />
{/if}

