import { Tabs, TabsContent, TabsList, TabsTrigger } from "@/components/ui/tabs";
import { PersonalInfo } from "./ProfileTabs/PersonalInfo";
const ProfileTabs = () => {
  return (
    <>
      <Tabs
        defaultValue="Personal Info"
        className="bg-background px-3 py-5 mb-0 rounded-lg transition-all duration-300 delay-300"
      >
        <TabsList className="flex justify-start gap-3 lg:gap-12 lg:px-6 bg-background mb-10 border-b-[1px]">
          <TabsTrigger disabled className=" lg:text-xl" value="Products">
            Products
          </TabsTrigger>
          <TabsTrigger className="lg:text-xl" value="Personal Info">
            Personal Info
          </TabsTrigger>
          <TabsTrigger disabled className="lg:text-xl" value="Notes">
            Notes
          </TabsTrigger>
          <TabsTrigger disabled className="lg:text-xl" value="Services">
            Services
          </TabsTrigger>
        </TabsList>

        <TabsContent
          value="Personal Info"
          className="flex flex-col rounded-lg p-4 gap-5 w-full transition-all duration-300 delay-300"
        >
          <PersonalInfo />
        </TabsContent>
      </Tabs>
    </>
  );
};

export default ProfileTabs;
