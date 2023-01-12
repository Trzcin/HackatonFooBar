<script lang="ts">
  import type Group from "../types/group";

  export let group: Group;
  export let color: string;
</script>

<div id="card" class="{color}">
  <h2>{group.name}</h2>
  <p>5.4/10</p>
</div>

<style>
  #card {
    width: 100%;
    border-radius: 5px;
    color: white;
    padding: 1rem 2rem;
    min-height: 10rem;
    position: relative;
  }

  p {
    text-align: center;
    margin-top: .8rem;
    font-size: 30px;
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
  }
</style>
