import { ProfileDetails } from "@/components/Profile/profileDetails";

export default function Profile() {
  return (
    <section className="mt-5 px-3 grid gap-5 lg:grid-cols-[30%_auto] lg:grid-rows-3 lg:p-[15px] lg:grid-flow-col xl:grid-cols-[27%_auto]">
      <div className="rounded-lg lg:row-span-2 lg:col-start-1">
        <div className="flex flex-col gap-5 rounded-lg lg:col-start-1">
          <div className="shadow-md bg-background rounded-lg">
            <ProfileDetails
              memberName="James Doe"
              memberNumber="17845500"
              dateOfBirth="12/21/1939"
              phone="+1(505)816-4459"
              email="James.doe@gmail.com"
              address="2-54 erkensel rd, Winnipeg MB, R1Y 2F9"
            />
          </div>
          <div className="h-[40px] shadow-md bg-background rounded-2xl">
            Verification Button
          </div>
        </div>
      </div>
      <div className="lg:row-span-3 lg:col-start-2">
        <div className="h-[600px] rounded-lg shadow-md bg-background">
          Member Profile Tabs
        </div>
      </div>
    </section>
  );
}
