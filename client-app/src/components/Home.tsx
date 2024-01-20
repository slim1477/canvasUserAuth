import { Tabs, TabsContent, TabsList, TabsTrigger } from "@/components/ui/tabs";
import { Input } from "./ui/input";
import { Button } from "./ui/button";

const Home = () => {
  return (
    <>
      <Tabs
        defaultValue="dashboard"
        className="bg-background px-3 py-5 shadow-lg"
      >
        <TabsList className="flex justify-start gap-3 lg:gap-12 lg:px-10 bg-background mb-10 border-b-2">
          <TabsTrigger
            className="data-[state=active]:bg-transparent data-[state=active]:border-primary-accent data-[state=active]:border-b-4 lg:text-xl"
            value="dashboard"
          >
            Dashboard
          </TabsTrigger>
          <TabsTrigger disabled className="lg:text-xl" value="tasks">
            Tasks
          </TabsTrigger>
          <TabsTrigger disabled className="lg:text-xl" value="pipeline">
            Pipeline
          </TabsTrigger>
          <TabsTrigger disabled className="lg:text-xl" value="Goals">
            Goals
          </TabsTrigger>
        </TabsList>
        <TabsContent
          value="dashboard"
          className="flex flex-col shadow-md p-4 border gap-5 mx-auto w-fit lg:w-[800px]"
        >
          <h2 className="text-xl text-primary-accent text-left">Search</h2>
          <div>
            <Input placeholder="search for person or business" />
          </div>
          <div className="flex gap-6">
            <Button variant="outline" disabled>
              New Member Applications
            </Button>
            <Button variant="outline" disabled>
              New Prospect
            </Button>
          </div>
        </TabsContent>
        <TabsContent value="password">Change your password here.</TabsContent>
      </Tabs>
    </>
  );
};

export default Home;
