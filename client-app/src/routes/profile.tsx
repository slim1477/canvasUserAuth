import { VerifyButton } from "@/components/verification/VerifyButton";
import { ProfileDetails } from "@/components/Profile/ProfileDetails";

export default function Profile() {
  return (
    <section className="mt-5 px-3 grid gap-5 lg:grid-cols-[30%_auto] lg:grid-rows-3 lg:p-[15px] lg:grid-flow-col xl:grid-cols-[27%_auto]">
      <div className="rounded-lg lg:row-span-2 lg:col-start-1">
        <div className="flex flex-col gap-5 rounded-lg lg:col-start-1">
          <div className="shadow-md bg-background rounded-lg">
            <ProfileDetails
              memberName="Demo Member"
              memberNumber="11111111"
              dateOfBirth="01/01/1939"
              phone="+1(204)111-1111"
              email="demo@email.com"
              address="123 demo street, Winnipeg MB, A1A 2B2"
            />
          </div>
          <div className="h-[50px] lg:w-[50%] lg:flex lg:justify-end">
            <VerifyButton />
          </div>
        </div>
      </div>
      <div className="lg:row-span-3 lg:col-start-2">
        <div className="h-[600px] border rounded-lg shadow-md bg-background">
          Member Profile Tabs
        </div>
      </div>
    </section>
  );
}
