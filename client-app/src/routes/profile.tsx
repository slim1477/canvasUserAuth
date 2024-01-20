import { VerifyButton } from "@/components/verification/VerifyButton";


export default function Profile() {
  return (
    <section className="mt-5 px-3 grid gap-5 lg:grid-cols-[30%_auto] lg:grid-rows-3 lg:p-[15px] lg:grid-flow-col ">
      <div className="rounded-lg lg:row-span-2 lg:col-start-1">
        <div className="flex flex-col gap-5 rounded-lg lg:col-start-1">
          <div className="h-[350px] shadow-md bg-background rounded-lg">
            Member Profile
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
