<script lang="ts">
  import type { Group } from "../groups";

  export let groups: Group[];
  export let displayGroups: Group[];
  let selectedGroups: string[] = ["Edukacja"];

  $: {
    displayGroups = groups.filter(g => selectedGroups.includes(g.name));
  }
</script>

<h2>Dobierz grupy</h2>
<div id="groups">
  {#each groups as group }
    <input type="checkbox" id="{group.name}" bind:group={selectedGroups} value="{group.name}"/>
    <label for="{group.name}" class:active={selectedGroups.includes(group.name)}>{group.name}</label>
  {/each}
</div>

<style>
  h2 {
    margin: 3rem 1.5rem 0 1.5rem;
  }

  #groups {
    margin: 1.5rem 2rem 0 1.5rem;
    display: flex;
    flex-wrap: wrap;
    gap: 2rem;
    row-gap: 1rem;
  }

  input {
    display: none;
  }

  label {
    display: block;
    flex: 1;
    text-align: center;
    background-color: #ddd;
    padding: .5rem 1rem;
    min-width: 30%;
    border-radius: 5px;
  }

  .active {
    background-color: #007bff;
    color: white;
  }
</style>
