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
    display: grid;
    grid-template-columns: 1fr 1fr 1fr;
    margin: 1.5rem 2rem;
    gap: 4rem;
  }
</style>
