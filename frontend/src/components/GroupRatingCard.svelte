<script lang="ts">
  import type {Group} from "../groups";

  export let group: Group;
  export let color: string;
</script>

<div id="card" class="{color}">
  <h3>{group.name}</h3>
  <p>{Math.floor(Math.random()*100)}%</p>
</div>

<style>
  #card {
    flex: 1;
    max-width: 15rem;
    min-width: 15rem;
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
