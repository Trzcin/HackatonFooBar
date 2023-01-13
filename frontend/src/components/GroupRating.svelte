<script lang="ts">

import type { Group } from "../groups";
  import GroupRatingCard from "./GroupRatingCard.svelte";

  export let groups: Group[];

  const colors = ['blue', 'teal', 'green', 'yellow', 'red'];
</script>

<div>
  {#each groups as group }
    <GroupRatingCard {group} color={colors[Math.floor(Math.random() * colors.length)]}/>
  {/each}
</div>

<style>
  div {
    display: flex;
    flex-wrap: wrap;
    margin: 1.5rem 2rem;
    gap: 2rem;
  }
</style>
