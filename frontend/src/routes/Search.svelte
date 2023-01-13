<script lang="ts">
  import Navbar from "../components/Navbar.svelte";
  import Map from "../components/Map.svelte";
  import CategoryGrid from "../components/CategoryGrid.svelte";
  import type Category from "../types/category";
  import CategoryFilterInput from "../components/CategoryFilterInput.svelte";
  import GroupPicker from "../components/GroupPicker.svelte";
  import Rating from "../components/Rating.svelte";
  import GroupRating from "../components/GroupRating.svelte";
  import { groups } from "../groups";
  import type { Group } from "../groups";
  import {onMount} from "svelte";
  import PrimaryRating from "../components/PrimaryRating.svelte";

  const data: Category[] = [
    {
      name: "apteka",
      nearest: {lon: 50, lat: 50},
      time: "7 minut",
      link: "google.com"
    },
    {
      name: "sklep spożywczy",
      nearest: {lon: 50, lat: 50},
      time: "7 minut"
    },
    {
      name: "przedszkole",
      nearest: {lon: 50, lat: 50},
      time: "7 minut"
    },
    {
      name: "szkoła podstawowa",
      nearest: {lon: 50, lat: 50},
      time: "7 minut"
    },
    {
      name: "przychodnia",
      nearest: {lon: 50, lat: 50},
      time: "7 minut"
    },
    {
      name: "restauracja",
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
  <PrimaryRating groups={groups.filter(g => g.primary)}/>
  <GroupPicker groups={groups.filter(g => !g.primary)} bind:displayGroups={displayGroups}/>
  <GroupRating groups={displayGroups}/>
  <CategoryFilterInput {data} bind:displayData={displayData} {groupData}/>
  <CategoryGrid data={displayData} />
{/if}

