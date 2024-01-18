import "@App.css";
import Home from "@/components/Home";

export default function Root() {
  return (
    <section className="flex h-screen w-full p-4">
      <div className="w-full">
        <Home />
      </div>
    </section>
  );
}
